using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000248 RID: 584
	[Serializable]
	public class MappedSpecialGuest : Object
	{
		// Token: 0x060048C2 RID: 18626 RVA: 0x0019AF44 File Offset: 0x00199144
		// Note: this type is marked as 'beforefieldinit'.
		static MappedSpecialGuest()
		{
			Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "MappedSpecialGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr);
			MappedSpecialGuest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, "id");
			MappedSpecialGuest.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, "stringId");
			MappedSpecialGuest.NativeFieldInfoPtr_sourceGuestID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, "sourceGuestID");
			MappedSpecialGuest.NativeFieldInfoPtr_overrideDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, "overrideDestination");
			MappedSpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Destination_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, 100677837);
			MappedSpecialGuest.NativeMethodInfoPtr_get_ID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, 100677838);
			MappedSpecialGuest.NativeMethodInfoPtr_get_StrID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, 100677839);
			MappedSpecialGuest.NativeMethodInfoPtr_get_SourceGuestID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, 100677840);
			MappedSpecialGuest.NativeMethodInfoPtr_get_OverrideDestination_Public_get_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, 100677841);
			MappedSpecialGuest.NativeMethodInfoPtr_GenerateDummy_Public_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr, 100677842);
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x0019B03C File Offset: 0x0019923C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190693, XrefRangeEnd = 190696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MappedSpecialGuest(int id, int sourceGuestID, NPC.Destination overrideDestination, string stringId) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MappedSpecialGuest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceGuestID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideDestination));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MappedSpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Destination_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x0019B0BC File Offset: 0x001992BC
		public unsafe int ID
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MappedSpecialGuest.NativeMethodInfoPtr_get_ID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x0019B0F8 File Offset: 0x001992F8
		public unsafe string StrID
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MappedSpecialGuest.NativeMethodInfoPtr_get_StrID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x0019B130 File Offset: 0x00199330
		public unsafe int SourceGuestID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 39817, RefRangeEnd = 39820, XrefRangeStart = 39817, XrefRangeEnd = 39820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MappedSpecialGuest.NativeMethodInfoPtr_get_SourceGuestID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x0019B16C File Offset: 0x0019936C
		public unsafe NPC.Destination OverrideDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MappedSpecialGuest.NativeMethodInfoPtr_get_OverrideDestination_Public_get_Destination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NPC.Destination(pointer);
			}
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x0019B1A4 File Offset: 0x001993A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190701, RefRangeEnd = 190702, XrefRangeStart = 190696, XrefRangeEnd = 190701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuest GenerateDummy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MappedSpecialGuest.NativeMethodInfoPtr_GenerateDummy_Public_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00025515 File Offset: 0x00023715
		public MappedSpecialGuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x060048CA RID: 18634 RVA: 0x0019B1E4 File Offset: 0x001993E4
		// (set) Token: 0x060048CB RID: 18635 RVA: 0x0002551E File Offset: 0x0002371E
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x0019B20C File Offset: 0x0019940C
		// (set) Token: 0x060048CD RID: 18637 RVA: 0x00025539 File Offset: 0x00023739
		public unsafe string stringId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_stringId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_stringId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x0019B234 File Offset: 0x00199434
		// (set) Token: 0x060048CF RID: 18639 RVA: 0x00025558 File Offset: 0x00023758
		public unsafe int sourceGuestID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_sourceGuestID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_sourceGuestID)) = value;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x0019B25C File Offset: 0x0019945C
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x00025573 File Offset: 0x00023773
		public NPC.Destination overrideDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_overrideDestination);
				return new NPC.Destination(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MappedSpecialGuest.NativeFieldInfoPtr_overrideDestination), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeFieldInfoPtr_stringId;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeFieldInfoPtr_sourceGuestID;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeFieldInfoPtr_overrideDestination;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Destination_String_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_get_Int32_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr_get_StrID_Public_get_String_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceGuestID_Public_get_Int32_0;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideDestination_Public_get_Destination_0;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeMethodInfoPtr_GenerateDummy_Public_SpecialGuest_0;
	}
}
