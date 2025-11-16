using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000429 RID: 1065
	public class COM_SetPlayerPref_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007892 RID: 30866 RVA: 0x0022F0B4 File Offset: 0x0022D2B4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SetPlayerPref_Behaviour()
		{
			Il2CppClassPointerStore<COM_SetPlayerPref_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SetPlayerPref_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SetPlayerPref_Behaviour>.NativeClassPtr);
			COM_SetPlayerPref_Behaviour.NativeFieldInfoPtr_playerPrefLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SetPlayerPref_Behaviour>.NativeClassPtr, "playerPrefLabel");
			COM_SetPlayerPref_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerPref_Behaviour>.NativeClassPtr, 100687654);
			COM_SetPlayerPref_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerPref_Behaviour>.NativeClassPtr, 100687655);
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x0022F120 File Offset: 0x0022D320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293663, XrefRangeEnd = 293667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SetPlayerPref_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x0022F15C File Offset: 0x0022D35C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SetPlayerPref_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SetPlayerPref_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SetPlayerPref_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00041349 File Offset: 0x0003F549
		public COM_SetPlayerPref_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06007896 RID: 30870 RVA: 0x0022F198 File Offset: 0x0022D398
		// (set) Token: 0x06007897 RID: 30871 RVA: 0x00041352 File Offset: 0x0003F552
		public unsafe string playerPrefLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerPref_Behaviour.NativeFieldInfoPtr_playerPrefLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerPref_Behaviour.NativeFieldInfoPtr_playerPrefLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F7C RID: 20348
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefLabel;

		// Token: 0x04004F7D RID: 20349
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F7E RID: 20350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
