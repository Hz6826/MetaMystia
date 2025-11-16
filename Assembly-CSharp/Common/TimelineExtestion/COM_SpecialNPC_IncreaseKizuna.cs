using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000408 RID: 1032
	public class COM_SpecialNPC_IncreaseKizuna : PlayableAsset
	{
		// Token: 0x0600775E RID: 30558 RVA: 0x0022BD30 File Offset: 0x00229F30
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SpecialNPC_IncreaseKizuna()
		{
			Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SpecialNPC_IncreaseKizuna");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr);
			COM_SpecialNPC_IncreaseKizuna.NativeFieldInfoPtr_targetCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr, "targetCharacterLabel");
			COM_SpecialNPC_IncreaseKizuna.NativeFieldInfoPtr_kizunaAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr, "kizunaAmount");
			COM_SpecialNPC_IncreaseKizuna.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr, 100687571);
			COM_SpecialNPC_IncreaseKizuna.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr, 100687572);
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x0022BDB0 File Offset: 0x00229FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293178, XrefRangeEnd = 293193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SpecialNPC_IncreaseKizuna.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x0022BE18 File Offset: 0x0022A018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SpecialNPC_IncreaseKizuna() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SpecialNPC_IncreaseKizuna>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SpecialNPC_IncreaseKizuna.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x0004089C File Offset: 0x0003EA9C
		public COM_SpecialNPC_IncreaseKizuna(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x06007762 RID: 30562 RVA: 0x0022BE54 File Offset: 0x0022A054
		// (set) Token: 0x06007763 RID: 30563 RVA: 0x000408A5 File Offset: 0x0003EAA5
		public unsafe string targetCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna.NativeFieldInfoPtr_targetCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna.NativeFieldInfoPtr_targetCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x0022BE7C File Offset: 0x0022A07C
		// (set) Token: 0x06007765 RID: 30565 RVA: 0x000408C4 File Offset: 0x0003EAC4
		public unsafe int kizunaAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna.NativeFieldInfoPtr_kizunaAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SpecialNPC_IncreaseKizuna.NativeFieldInfoPtr_kizunaAmount)) = value;
			}
		}

		// Token: 0x04004EDE RID: 20190
		private static readonly IntPtr NativeFieldInfoPtr_targetCharacterLabel;

		// Token: 0x04004EDF RID: 20191
		private static readonly IntPtr NativeFieldInfoPtr_kizunaAmount;

		// Token: 0x04004EE0 RID: 20192
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EE1 RID: 20193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
