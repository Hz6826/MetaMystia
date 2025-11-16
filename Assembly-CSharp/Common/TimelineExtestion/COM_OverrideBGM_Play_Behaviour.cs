using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000443 RID: 1091
	public class COM_OverrideBGM_Play_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007965 RID: 31077 RVA: 0x002313A0 File Offset: 0x0022F5A0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_OverrideBGM_Play_Behaviour()
		{
			Il2CppClassPointerStore<COM_OverrideBGM_Play_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_OverrideBGM_Play_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_OverrideBGM_Play_Behaviour>.NativeClassPtr);
			COM_OverrideBGM_Play_Behaviour.NativeFieldInfoPtr_musicPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_OverrideBGM_Play_Behaviour>.NativeClassPtr, "musicPackage");
			COM_OverrideBGM_Play_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Play_Behaviour>.NativeClassPtr, 100687727);
			COM_OverrideBGM_Play_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Play_Behaviour>.NativeClassPtr, 100687728);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x0023140C File Offset: 0x0022F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294077, XrefRangeEnd = 294081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_OverrideBGM_Play_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x00231448 File Offset: 0x0022F648
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_OverrideBGM_Play_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_OverrideBGM_Play_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_OverrideBGM_Play_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x0004198C File Offset: 0x0003FB8C
		public COM_OverrideBGM_Play_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x06007969 RID: 31081 RVA: 0x00231484 File Offset: 0x0022F684
		// (set) Token: 0x0600796A RID: 31082 RVA: 0x00041995 File Offset: 0x0003FB95
		public unsafe LoopedBGMPackage musicPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_Play_Behaviour.NativeFieldInfoPtr_musicPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_Play_Behaviour.NativeFieldInfoPtr_musicPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FE9 RID: 20457
		private static readonly IntPtr NativeFieldInfoPtr_musicPackage;

		// Token: 0x04004FEA RID: 20458
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FEB RID: 20459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
