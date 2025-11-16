using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000445 RID: 1093
	public class COM_OverrideBGM_PauseOrResume_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007971 RID: 31089 RVA: 0x002315C8 File Offset: 0x0022F7C8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_OverrideBGM_PauseOrResume_Behaviour()
		{
			Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_OverrideBGM_PauseOrResume_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume_Behaviour>.NativeClassPtr);
			COM_OverrideBGM_PauseOrResume_Behaviour.NativeFieldInfoPtr_shouldResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume_Behaviour>.NativeClassPtr, "shouldResume");
			COM_OverrideBGM_PauseOrResume_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume_Behaviour>.NativeClassPtr, 100687731);
			COM_OverrideBGM_PauseOrResume_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume_Behaviour>.NativeClassPtr, 100687732);
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x00231634 File Offset: 0x0022F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294086, XrefRangeEnd = 294093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_OverrideBGM_PauseOrResume_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x00231670 File Offset: 0x0022F870
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_OverrideBGM_PauseOrResume_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_OverrideBGM_PauseOrResume_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x000419DC File Offset: 0x0003FBDC
		public COM_OverrideBGM_PauseOrResume_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x002316AC File Offset: 0x0022F8AC
		// (set) Token: 0x06007976 RID: 31094 RVA: 0x000419E5 File Offset: 0x0003FBE5
		public unsafe bool shouldResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_PauseOrResume_Behaviour.NativeFieldInfoPtr_shouldResume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_PauseOrResume_Behaviour.NativeFieldInfoPtr_shouldResume)) = value;
			}
		}

		// Token: 0x04004FEF RID: 20463
		private static readonly IntPtr NativeFieldInfoPtr_shouldResume;

		// Token: 0x04004FF0 RID: 20464
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FF1 RID: 20465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
