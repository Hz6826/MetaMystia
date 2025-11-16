using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000448 RID: 1096
	public class COM_SpecialNPC_IncreaseKizuna_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007983 RID: 31107 RVA: 0x002318EC File Offset: 0x0022FAEC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SpecialNPC_IncreaseKizuna_Behaviour()
		{
			Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SpecialNPC_IncreaseKizuna_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr);
			COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeFieldInfoPtr_kizunaAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr, "kizunaAmount");
			COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeFieldInfoPtr_targetCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr, "targetCharacterLabel");
			COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr, 100687737);
			COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr, 100687738);
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x0023196C File Offset: 0x0022FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294104, XrefRangeEnd = 294108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x002319A8 File Offset: 0x0022FBA8
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SpecialNPC_IncreaseKizuna_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x00041A48 File Offset: 0x0003FC48
		public COM_SpecialNPC_IncreaseKizuna_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x002319E4 File Offset: 0x0022FBE4
		// (set) Token: 0x06007988 RID: 31112 RVA: 0x00041A51 File Offset: 0x0003FC51
		public unsafe int kizunaAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeFieldInfoPtr_kizunaAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeFieldInfoPtr_kizunaAmount)) = value;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06007989 RID: 31113 RVA: 0x00231A0C File Offset: 0x0022FC0C
		// (set) Token: 0x0600798A RID: 31114 RVA: 0x00041A6C File Offset: 0x0003FC6C
		public unsafe string targetCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeFieldInfoPtr_targetCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna_Behaviour.NativeFieldInfoPtr_targetCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004FF8 RID: 20472
		private static readonly IntPtr NativeFieldInfoPtr_kizunaAmount;

		// Token: 0x04004FF9 RID: 20473
		private static readonly IntPtr NativeFieldInfoPtr_targetCharacterLabel;

		// Token: 0x04004FFA RID: 20474
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FFB RID: 20475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
