using System;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x0200029B RID: 667
	[Serializable]
	public sealed class NPC : ValueType
	{
		// Token: 0x060054FF RID: 21759 RVA: 0x001BD298 File Offset: 0x001BB498
		// Note: this type is marked as 'beforefieldinit'.
		static NPC()
		{
			Il2CppClassPointerStore<NPC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "NPC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC>.NativeClassPtr);
			NPC.NativeFieldInfoPtr_defaultDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "defaultDestination");
			NPC.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "key");
			NPC.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "identity");
			NPC.NativeFieldInfoPtr_offByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "offByDefault");
			NPC.NativeFieldInfoPtr_showTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "showTime");
			NPC.NativeFieldInfoPtr_restTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "restTime");
			NPC.NativeFieldInfoPtr_possibleDestinations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "possibleDestinations");
			NPC.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680668);
			NPC.NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680669);
			NPC.NativeMethodInfoPtr_GetTrueShowAction_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680670);
			NPC.NativeMethodInfoPtr_GenerateFirstDestination_Public_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680671);
			NPC.NativeMethodInfoPtr_GenerateNextDestination_Public_Destination_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680672);
			NPC.NativeMethodInfoPtr_GenerateRestDays_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680673);
			NPC.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100680674);
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x001BD3E0 File Offset: 0x001BB5E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212622, RefRangeEnd = 212624, XrefRangeStart = 212599, XrefRangeEnd = 212622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC(SpecialGuest specialNPC) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPC);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x001BD430 File Offset: 0x001BB630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212624, XrefRangeEnd = 212625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSpriteSetCompact GetVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x001BD474 File Offset: 0x001BB674
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212625, RefRangeEnd = 212628, XrefRangeStart = 212625, XrefRangeEnd = 212625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetTrueShowAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GetTrueShowAction_Public_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x001BD4B8 File Offset: 0x001BB6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212632, RefRangeEnd = 212633, XrefRangeStart = 212628, XrefRangeEnd = 212632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC.Destination GenerateFirstDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GenerateFirstDestination_Public_Destination_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NPC.Destination(pointer);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x001BD4F4 File Offset: 0x001BB6F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212639, RefRangeEnd = 212640, XrefRangeStart = 212633, XrefRangeEnd = 212639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC.Destination GenerateNextDestination(NPC.Destination destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GenerateNextDestination_Public_Destination_Destination_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NPC.Destination(pointer);
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x001BD548 File Offset: 0x001BB748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212641, RefRangeEnd = 212643, XrefRangeStart = 212640, XrefRangeEnd = 212641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GenerateRestDays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GenerateRestDays_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x001BD58C File Offset: 0x001BB78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212643, XrefRangeEnd = 212649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x0002DBC9 File Offset: 0x0002BDC9
		public NPC(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x0002DBD2 File Offset: 0x0002BDD2
		public NPC() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC>.NativeClassPtr))
		{
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x001BD5C8 File Offset: 0x001BB7C8
		// (set) Token: 0x0600550A RID: 21770 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
		public unsafe static NPC.Destination defaultDestination
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(NPC.NativeFieldInfoPtr_defaultDestination, intPtr);
				return new NPC.Destination(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPC.NativeFieldInfoPtr_defaultDestination, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x001BD604 File Offset: 0x001BB804
		// (set) Token: 0x0600550C RID: 21772 RVA: 0x0002DBFB File Offset: 0x0002BDFB
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x0600550D RID: 21773 RVA: 0x001BD62C File Offset: 0x001BB82C
		// (set) Token: 0x0600550E RID: 21774 RVA: 0x0002DC1A File Offset: 0x0002BE1A
		public unsafe SchedulerNode.Character identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_identity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_identity)) = value;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x001BD654 File Offset: 0x001BB854
		// (set) Token: 0x06005510 RID: 21776 RVA: 0x0002DC35 File Offset: 0x0002BE35
		public unsafe bool offByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_offByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_offByDefault)) = value;
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x001BD67C File Offset: 0x001BB87C
		// (set) Token: 0x06005512 RID: 21778 RVA: 0x0002DC50 File Offset: 0x0002BE50
		public unsafe Vector2Int showTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_showTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_showTime)) = value;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x001BD6A4 File Offset: 0x001BB8A4
		// (set) Token: 0x06005514 RID: 21780 RVA: 0x0002DC6B File Offset: 0x0002BE6B
		public unsafe Vector2Int restTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_restTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_restTime)) = value;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x001BD6CC File Offset: 0x001BB8CC
		// (set) Token: 0x06005516 RID: 21782 RVA: 0x0002DC86 File Offset: 0x0002BE86
		public unsafe Il2CppReferenceArray<NPC.Destination> possibleDestinations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_possibleDestinations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC.Destination>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_possibleDestinations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003917 RID: 14615
		private static readonly IntPtr NativeFieldInfoPtr_defaultDestination;

		// Token: 0x04003918 RID: 14616
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04003919 RID: 14617
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x0400391A RID: 14618
		private static readonly IntPtr NativeFieldInfoPtr_offByDefault;

		// Token: 0x0400391B RID: 14619
		private static readonly IntPtr NativeFieldInfoPtr_showTime;

		// Token: 0x0400391C RID: 14620
		private static readonly IntPtr NativeFieldInfoPtr_restTime;

		// Token: 0x0400391D RID: 14621
		private static readonly IntPtr NativeFieldInfoPtr_possibleDestinations;

		// Token: 0x0400391E RID: 14622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_0;

		// Token: 0x0400391F RID: 14623
		private static readonly IntPtr NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0;

		// Token: 0x04003920 RID: 14624
		private static readonly IntPtr NativeMethodInfoPtr_GetTrueShowAction_Public_Vector2Int_0;

		// Token: 0x04003921 RID: 14625
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFirstDestination_Public_Destination_0;

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNextDestination_Public_Destination_Destination_0;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRestDays_Public_Int32_0;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000C46 RID: 3142
		[Serializable]
		public sealed class Destination : ValueType
		{
			// Token: 0x0600E373 RID: 58227 RVA: 0x0036C24C File Offset: 0x0036A44C
			// Note: this type is marked as 'beforefieldinit'.
			static Destination()
			{
				Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPC>.NativeClassPtr, "Destination");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr);
				NPC.Destination.NativeFieldInfoPtr_spawnMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, "spawnMarker");
				NPC.Destination.NativeFieldInfoPtr_stayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, "stayTime");
				NPC.Destination.NativeFieldInfoPtr_initialDialogPackIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, "initialDialogPackIDs");
				NPC.Destination.NativeFieldInfoPtr_interactiveAreaSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, "interactiveAreaSize");
				NPC.Destination.NativeMethodInfoPtr_get_None_Public_Static_get_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, 100680676);
				NPC.Destination.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, 100680677);
				NPC.Destination.NativeMethodInfoPtr_GenerateStayDays_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, 100680678);
				NPC.Destination.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, 100680679);
			}

			// Token: 0x170049DE RID: 18910
			// (get) Token: 0x0600E374 RID: 58228 RVA: 0x0036C318 File Offset: 0x0036A518
			public unsafe static NPC.Destination None
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212582, XrefRangeEnd = 212588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NPC.Destination.NativeMethodInfoPtr_get_None_Public_Static_get_Destination_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new NPC.Destination(pointer);
				}
			}

			// Token: 0x0600E375 RID: 58229 RVA: 0x0036C344 File Offset: 0x0036A544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212588, XrefRangeEnd = 212590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(NPC.Destination other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.Destination.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Destination_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E376 RID: 58230 RVA: 0x0036C39C File Offset: 0x0036A59C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 212591, RefRangeEnd = 212593, XrefRangeStart = 212590, XrefRangeEnd = 212591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GenerateStayDays()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.Destination.NativeMethodInfoPtr_GenerateStayDays_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E377 RID: 58231 RVA: 0x0036C3E0 File Offset: 0x0036A5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212593, XrefRangeEnd = 212599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.Destination.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E378 RID: 58232 RVA: 0x00079529 File Offset: 0x00077729
			public Destination(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E379 RID: 58233 RVA: 0x00079532 File Offset: 0x00077732
			public Destination() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr))
			{
			}

			// Token: 0x170049DA RID: 18906
			// (get) Token: 0x0600E37A RID: 58234 RVA: 0x0036C41C File Offset: 0x0036A61C
			// (set) Token: 0x0600E37B RID: 58235 RVA: 0x00079544 File Offset: 0x00077744
			public unsafe string spawnMarker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_spawnMarker);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_spawnMarker), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049DB RID: 18907
			// (get) Token: 0x0600E37C RID: 58236 RVA: 0x0036C444 File Offset: 0x0036A644
			// (set) Token: 0x0600E37D RID: 58237 RVA: 0x00079563 File Offset: 0x00077763
			public unsafe Vector2Int stayTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_stayTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_stayTime)) = value;
				}
			}

			// Token: 0x170049DC RID: 18908
			// (get) Token: 0x0600E37E RID: 58238 RVA: 0x0036C46C File Offset: 0x0036A66C
			// (set) Token: 0x0600E37F RID: 58239 RVA: 0x0007957E File Offset: 0x0007777E
			public unsafe Il2CppStringArray initialDialogPackIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_initialDialogPackIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_initialDialogPackIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049DD RID: 18909
			// (get) Token: 0x0600E380 RID: 58240 RVA: 0x0036C49C File Offset: 0x0036A69C
			// (set) Token: 0x0600E381 RID: 58241 RVA: 0x0007959D File Offset: 0x0007779D
			public unsafe float interactiveAreaSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_interactiveAreaSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.Destination.NativeFieldInfoPtr_interactiveAreaSize)) = value;
				}
			}

			// Token: 0x04009160 RID: 37216
			private static readonly IntPtr NativeFieldInfoPtr_spawnMarker;

			// Token: 0x04009161 RID: 37217
			private static readonly IntPtr NativeFieldInfoPtr_stayTime;

			// Token: 0x04009162 RID: 37218
			private static readonly IntPtr NativeFieldInfoPtr_initialDialogPackIDs;

			// Token: 0x04009163 RID: 37219
			private static readonly IntPtr NativeFieldInfoPtr_interactiveAreaSize;

			// Token: 0x04009164 RID: 37220
			private static readonly IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_Destination_0;

			// Token: 0x04009165 RID: 37221
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Destination_0;

			// Token: 0x04009166 RID: 37222
			private static readonly IntPtr NativeMethodInfoPtr_GenerateStayDays_Public_Int32_0;

			// Token: 0x04009167 RID: 37223
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}
	}
}
