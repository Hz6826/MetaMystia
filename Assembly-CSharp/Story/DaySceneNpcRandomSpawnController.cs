using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Story
{
	// Token: 0x02000031 RID: 49
	public class DaySceneNpcRandomSpawnController : MonoBehaviour
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x000AF120 File Offset: 0x000AD320
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneNpcRandomSpawnController()
		{
			Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Story", "DaySceneNpcRandomSpawnController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr);
			DaySceneNpcRandomSpawnController.NativeFieldInfoPtr_m_NpcLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, "m_NpcLabel");
			DaySceneNpcRandomSpawnController.NativeFieldInfoPtr_m_Maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, "m_Maps");
			DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, 100664010);
			DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, 100664011);
			DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_UpdateNpcPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, 100664012);
			DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_UpdateNpcPosition_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, 100664013);
			DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, 100664014);
			DaySceneNpcRandomSpawnController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, 100664015);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000AF1F0 File Offset: 0x000AD3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23953, XrefRangeEnd = 23971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000AF224 File Offset: 0x000AD424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23971, XrefRangeEnd = 23989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000AF258 File Offset: 0x000AD458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24032, RefRangeEnd = 24033, XrefRangeStart = 23989, XrefRangeEnd = 24032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNpcPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_UpdateNpcPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000AF28C File Offset: 0x000AD48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24033, XrefRangeEnd = 24035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNpcPosition(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_UpdateNpcPosition_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000AF2D0 File Offset: 0x000AD4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24035, XrefRangeEnd = 24037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneNpcRandomSpawnController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000AF30C File Offset: 0x000AD50C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneNpcRandomSpawnController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneNpcRandomSpawnController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00005071 File Offset: 0x00003271
		public DaySceneNpcRandomSpawnController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x000AF348 File Offset: 0x000AD548
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0000507A File Offset: 0x0000327A
		public unsafe string m_NpcLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.NativeFieldInfoPtr_m_NpcLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.NativeFieldInfoPtr_m_NpcLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x000AF370 File Offset: 0x000AD570
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00005099 File Offset: 0x00003299
		public unsafe Il2CppReferenceArray<DaySceneNpcRandomSpawnController.RandomSpawnData> m_Maps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.NativeFieldInfoPtr_m_Maps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneNpcRandomSpawnController.RandomSpawnData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.NativeFieldInfoPtr_m_Maps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr_m_NpcLabel;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr_m_Maps;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNpcPosition_Private_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNpcPosition_Private_Void_String_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004AD RID: 1197
		[Serializable]
		public sealed class RandomSpawnData : ValueType
		{
			// Token: 0x06007ECF RID: 32463 RVA: 0x00241BAC File Offset: 0x0023FDAC
			// Note: this type is marked as 'beforefieldinit'.
			static RandomSpawnData()
			{
				Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController>.NativeClassPtr, "RandomSpawnData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr);
				DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_MapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr, "MapLabel");
				DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr, "EventId");
				DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr, "Position");
			}

			// Token: 0x06007ED0 RID: 32464 RVA: 0x00044364 File Offset: 0x00042564
			public RandomSpawnData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007ED1 RID: 32465 RVA: 0x0004436D File Offset: 0x0004256D
			public RandomSpawnData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr))
			{
			}

			// Token: 0x17002ACE RID: 10958
			// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x00241C14 File Offset: 0x0023FE14
			// (set) Token: 0x06007ED3 RID: 32467 RVA: 0x0004437F File Offset: 0x0004257F
			public unsafe string MapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_MapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_MapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002ACF RID: 10959
			// (get) Token: 0x06007ED4 RID: 32468 RVA: 0x00241C3C File Offset: 0x0023FE3C
			// (set) Token: 0x06007ED5 RID: 32469 RVA: 0x0004439E File Offset: 0x0004259E
			public unsafe string EventId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_EventId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_EventId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002AD0 RID: 10960
			// (get) Token: 0x06007ED6 RID: 32470 RVA: 0x00241C64 File Offset: 0x0023FE64
			// (set) Token: 0x06007ED7 RID: 32471 RVA: 0x000443BD File Offset: 0x000425BD
			public unsafe Il2CppReferenceArray<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<Vector2, DayScenePlayerInputGenerator.CharacterRotation>> Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_Position);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<Vector2, DayScenePlayerInputGenerator.CharacterRotation>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.NativeFieldInfoPtr_Position), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005364 RID: 21348
			private static readonly IntPtr NativeFieldInfoPtr_MapLabel;

			// Token: 0x04005365 RID: 21349
			private static readonly IntPtr NativeFieldInfoPtr_EventId;

			// Token: 0x04005366 RID: 21350
			private static readonly IntPtr NativeFieldInfoPtr_Position;

			// Token: 0x02000FAA RID: 4010
			[Serializable]
			public sealed class KeyValuePair<TKey, TValue> : ValueType
			{
				// Token: 0x060114C7 RID: 70855 RVA: 0x003FB17C File Offset: 0x003F937C
				// Note: this type is marked as 'beforefieldinit'.
				static KeyValuePair()
				{
					Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData>.NativeClassPtr, "KeyValuePair`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>>.NativeClassPtr);
					DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>>.NativeClassPtr, "Position");
					DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>>.NativeClassPtr, "Rotation");
				}

				// Token: 0x060114C8 RID: 70856 RVA: 0x000967E5 File Offset: 0x000949E5
				public KeyValuePair(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060114C9 RID: 70857 RVA: 0x000967EE File Offset: 0x000949EE
				public KeyValuePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>>.NativeClassPtr))
				{
				}

				// Token: 0x170059EC RID: 23020
				// (get) Token: 0x060114CA RID: 70858 RVA: 0x003FB21C File Offset: 0x003F941C
				// (set) Token: 0x060114CB RID: 70859 RVA: 0x003FB244 File Offset: 0x003F9444
				public unsafe TKey Position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Position);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Position);
						Type typeFromHandle = typeof(TKey);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x170059ED RID: 23021
				// (get) Token: 0x060114CC RID: 70860 RVA: 0x003FB2EC File Offset: 0x003F94EC
				// (set) Token: 0x060114CD RID: 70861 RVA: 0x003FB314 File Offset: 0x003F9514
				public unsafe TValue Rotation
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Rotation);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Rotation);
						Type typeFromHandle = typeof(TValue);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x0400AEDB RID: 44763
				private static readonly IntPtr NativeFieldInfoPtr_Position;

				// Token: 0x0400AEDC RID: 44764
				private static readonly IntPtr NativeFieldInfoPtr_Rotation;
			}
		}
	}
}
